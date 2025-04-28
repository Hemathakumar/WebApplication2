$("#Id").blur(function () {
    var id = $(this).val();
    if (id === "") {
        $("#idError").text("Enter ID value");
    } else {
        $("#idError").text(""); // Clear error if valid
    }
});
$("#Name").blur(function () {
    var name = $(this).val();
    if (name === "") {
        $("#nameError").text("Enter Name");
    } else {
        $("#nameError").text(""); // Clear error if valid
    }
});
$("#Department").blur(function () {
    var dept = $(this).val();
    if (dept === "") {
        $("#deptError").text("Enter department");
    } else {
        $("#deptError").text(""); // Clear error if valid
    }
});
$("#Salary").blur(function () {
    var salary = $(this).val();
    if (salary === "") {
        $("#salaryError").text("Enter Salary");
    } else {

        if (salary <= 0)
            $("#salaryError").text("Enter Salary  more then 0 value");
        else if (salary == "")
            $("#salaryError").text("Enter Salary");
        else
            $("#salaryError").text("Enter Salary");
    }
});

$("#employeeForm").submit(function (e) {
    $("#Id, #Name, #Department, #Salary").blur();
    e.preventDefault();
});