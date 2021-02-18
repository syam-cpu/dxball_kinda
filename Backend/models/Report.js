const mongoose = require("mongoose");
const Schema = mongoose.Schema;

const ReportSchema = new Schema({
	date:{
		type:Date,
		default: Date()
	},
	lr:{
		type:String,
		required: true
	},
	rr:{
		type:String,
		required: true
	},
	data:{
		type: String,
		required: true
	}
});

module.exports = Report = mongoose.model("Report", ReportSchema);