var express = require("express");
var router = express.Router();
const bcrypt = require("bcryptjs");
const jwt = require("jsonwebtoken");
// Load User model

const Login = require("../models/Login");

// Adding a new user
router.route("/new_doctor").post(function (req, res) {
  let send = {
    status: "-1",
    msg: "temp",
  };

  let user = new Login(req.body);

  const { name, email, password } = req.body;
  if (!email || !password || !name) {
    send.msg = "Incomplete fields";
    send.status = "2";
    res.json(send);
  } 
  else {
    Login.findOne({ email }).then((user) => {
      if (user) {
        send.msg = "Username exists already";
        send.status = "3";
        res.json(send);
      }

      const newUser = new Login({
        name,
        email,
        password,
      });

      bcrypt.genSalt(10, (err, salt) => {
        bcrypt.hash(newUser.password, salt, (err, hash) => {
          if (err) throw err;
          newUser.password = hash;
          newUser.save();

          send.msg = "Successfully Added";
          send.status = "0";
          res.json(send);
        });
      });
    });
  }
});

// Login an existing user
userRoutes.route("/login").post(function (req, res) {
  let send = {
    status: "-1",
    msg: "temp",
    type: "",
  };

  let Email = req.body.email;
  let Password = req.body.password;

  User.findOne({ email: Email }).then((user) => {
    if (!user) {
      send.msg = "User does not exist";
      send.status = "2";
      res.json(send);
    }

    bcrypt.compare(Password, user.password).then((isMatch) => {
      if (!isMatch) {
        send.msg = "Wrong password";
        send.status = "3";
        res.json(send);
      } else {
        send.msg = "Credentials Valid";
        send.status = "0";
        send.type = user.user_type;
        res.json(send);
      }
    });
  });
});
