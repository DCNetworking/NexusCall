document.addEventListener("DOMContentLoaded", async function () {
    const a = document.querySelectorAll('a');
    for (const item of a) {
        if (!item.id.includes("openModalLink")) {
            continue;
        }
        item.addEventListener("click", async (e) => {
            e.preventDefault();
            const openModalLink = document.getElementById(item.id);
            const modal = document.querySelector("#myModal");
            let title = modal.querySelector("h3");
            const modalContentPlaceholder = document.getElementById("modalContentPlaceholder");
            const closeBtn = document.getElementsByClassName("close")[0];
            await loadModalContent(openModalLink, modalContentPlaceholder, title, item.innerText).then(() => {
                modal.style.display = "block";
            })
            closeBtn.addEventListener("click", () => {
                modal.style.display = "none";
                modalContentPlaceholder.innerHTML = "";
                title.textContent = "";
            });
            async function loadModalContent(openModalLink, modalContentPlaceholder, title, contentTitle) {
                const xhr = new XMLHttpRequest();
                const href = openModalLink.getAttribute("href").split("/");
                redirectController = href[1];
                redirectAction = href[2];
                xhr.onreadystatechange = () => {
                    if (xhr.readyState === XMLHttpRequest.DONE) {
                        if (xhr.status === 200) {
                            title.textContent = contentTitle;
                            modalContentPlaceholder.innerHTML = xhr.responseText;
                        } else {
                            console.log("Error loading modal content.");
                        }
                    }
                };
                xhr.open("GET", `/${redirectController}/${redirectAction}`, true);
                xhr.send();
            }
        });
    }
});

function markNotificationAsRead(Id) {
    // Perform your desired action here
    // You can use AJAX to send a request to the server or perform any other JavaScript action

    // Example: Send a POST request to mark the notification as read
    fetch(`Global/Notifications/mark-as-read`, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({ Id: Id })
    })
        .then(response => {
            if (response.ok) {
                alert("OK")
            } else {
                alert("FALSE")
            }
        })
        .catch(error => {
            console.error('An error occurred:', error);
        });
}