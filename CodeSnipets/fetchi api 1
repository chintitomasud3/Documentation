fetch('http://192.168.0.184:8080/Employee.json')
    .then(response => response.json())
    .then(data => {
        console.log(data);
        let rows = '';
        data.employees.forEach(item => {
            rows += `
                <tr>
                    <td>${item.name}</td>
                    <td>${item.email}</td>
                </tr>
            `;
        });

        $('#data_masud').html(rows);
    })
    .catch(error => $('p').append(`Error: ${error.message}`));
    
    
    
    
    
     <table class="table table-bordered">
        <thead>
            <tr>
                <th>Name</th>
                <th>Email</th>

            </tr>

        </thead>
        <tbody id="data_masud">
            <tr>


            </tr>
        </tbody>

    </table>
