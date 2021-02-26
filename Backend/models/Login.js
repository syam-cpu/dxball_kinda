const mongoose = require("mongoose");
const Schema = mongoose.Schema;

const LoginSchema = new Schema({
	name: {
		type: String,
		required: true
	},
	email: {
		type: Date,
		required: true
	},
	password: {
		type: String,
		required: true
	},
	report: {
		type: [] 
	}
});
 
module.exports = Login = mongoose.model("Login", LoginSchema);
