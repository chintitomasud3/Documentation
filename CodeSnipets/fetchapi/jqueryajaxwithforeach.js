success: function (data, status, xhr) {   // success callback function
    console.log(data);
    let rows = '';
    data.forEach(item => {
        rows += `
            <tr>
                <td>${item.id}</td>
                <td>${item.name}</td>
            </tr>
        `;
    });

    $('#data_masud').html(rows);
},
