var express = require("express");
var router = express.Router();

// Load User model
const Patient = require("../models/Patient");
const Report = require("../models/Report");


router.route("/insert_calculated_values").post(function (req, res) {
    _id = req.body.report_id
    Clickerdata = req.body.Clickerdata
    let i = 0
    False_POS = 0
    False_NEG = 0
    var Click_value = new Array(100);

    for (var i = 0; i < Click_value.length; i++) {
        Click_value[i] = new Array(100);
    }

    for (i = 0; i < Clickerdata.length; i++) {
        sample_instance = Clickerdata[i]
        x = sample_instance.x
        y = sample_instance.y
        click_type = sample_instance.click_type
        if (click_type && sample_instance.x != -1 && sample_instance.y !=- 1)
            Click_value[x][y]++
    }
    for (i = 0; i < Clickerdata.length; i++) {
        sample_instance = Clickerdata[i]

        if (sample_instance.x == -1 && sample_instance.y == -1) {
            if (sample_instance.click = 1) {
                False_POS++;
            }
        }
        else if (sample_instance.x != -1 && sample_instance.y != -1) {
            if(Click_value[sample_instance.x][sample_instance.y] > 0  && sample_instance.click_type == 0){
                False_NEG++;
            }

        }
    }

    userObj = {
        False_POS : False_POS,
        False_NEG : False_NEG,
        
    }



    Report.findOneAndUpdate({ _id }, { $set: userObj }, { upsert: true, new: true });


})