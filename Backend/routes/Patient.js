var express = require("express");
var router = express.Router();

// Load User model
const Patient = require("../models/Patient");
const Report = require("../models/Report");

router.post("/register", (req, res) => {
  const newReport = new Report({
    lr: req.body.lr,
    rr: req.body.rr,
    data: req.body.data,
    check_id: req.body.doctor_id
  });
  
  const newPatient = new Patient({
    name: req.body.name,
    dob: new Date(req.body.dob),
    report: [],
  });

  newReport
    .save()
    .then((report) => {
      newPatient.report.push(report._id);
      console.log("Successfully added" + report);
    })
    .catch((err) => {
      console.log("Error occured" + err);
    });

  newPatient
    .save()
    .then((patient) => {
      res.status(200).json(patient);
    })
    .catch((err) => {
      res.status(400).send(err);
    });
});

module.exports = router;
