success: function (data, status, xhr) {   // success callback function
    console.log(data);
    const rows = data.map(item => `
        <tr>
            <td>${item.id}</td>
            <td>${item.name}</td>
        </tr>
    `).join('');

    $('#data_masud').html(rows);
},
