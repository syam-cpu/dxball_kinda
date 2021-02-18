const mongoose = require("mongoose");
const Schema = mongoose.Schema;

const PatientSchema = new Schema({
	name: {
		type: String,
		required: true
	},
	dob: {
		type: Date,
		required: true
	},
	report: {
		type: [] 
	}
});
 
module.exports = Patient = mongoose.model("Patient", PatientSchema);
