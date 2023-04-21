async function loadImage() {
            try {
                const response = await fetch("goldendog.png");
                const blob = await response.blob();
                console.log(blob);
                document.getElementById("rainbow").src = URL.createObjectURL(blob);
            } catch (error) {
                console.log("error");
                console.error("something is missing");
                console.error(error);
            }
        }

        loadImage();
