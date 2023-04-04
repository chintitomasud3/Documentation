function fetchISSLocation(callback) {
    fetch('http://api.open-notify.org/iss-now.json')
      .then(response => response.json())
      .then(data => callback(data))
      .catch(error => console.log("Error fetching ISS location:", error.message));
  }
  
  fetchISSLocation(displayISSLocation);
  
  function displayISSLocation(issLocation) {
    const para = document.createElement("p");
    para.innerText = issLocation.message;
    document.body.appendChild(para);
  }
