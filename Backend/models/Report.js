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
	Fixation_Monitor:{
		type:String,
		required: true,
		default: 'Gaze/Blind Spot'
	},
	Fixation_Target:{
		type:String,
		required: true,
		default: 'Central'
	},
	False_POS:{
		type: Number,
		default: 0
	},
	False_NEG:{
		type: Number,
		default: 0
	},
	Fixation_loss:{
		type: Number,
		default: 0
	},
	Test_duration:{
		type: Number
	},
	Stimulus:{
		type: String,
		required: true,
		default: "White"
	},
	Background:{
		type: String,
		default: "31.5 ASB"
	},
	Strategy:{
		type: String,
		required: true,
		default: "SITA-Standard"
	},
	Visual_acuity:{
		type: String,
		required: true		
	},
	data:{
		type: String,
		required: true
	}
});

module.exports = Report = mongoose.model("Report", ReportSchema);