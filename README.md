This is a VR based Glaucoma detection test

1)For doctor we have included acount registration and login along with password encryption (/routes/login.js)

2)Included All the required attributes in Report schema (/models/report.js)

3)While registering we are saving the report by including all the parameters that need to be filled before the test (/routes/patient.js)

4)We have calculated False positive and False negative errors by using the clicker data (assumed to be a array of obejcts({x:'x_value',y:'y_value',click_type:'0 or 1'})).These values are also updated in the report
