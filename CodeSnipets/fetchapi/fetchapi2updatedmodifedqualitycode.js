function fetchEmployeeData(url, elementId) {
    fetch(url)
        .then(response => response.json())
        .then(data => {
            console.log(data);
            let rows = '';
            data.employees.forEach(item => {
                rows += '<tr>' +
                    '<td>' + item.name + '</td>' +
                    '<td>' + item.email + '</td>' +
                    '</tr>';
            });

            $('#' + elementId).html(rows);
        })
        .catch(error => $('p').append(`Error: ${error.message}`));
}

fetchEmployeeData('http://192.168.0.184:8080/Employee.json', 'data_masud');
