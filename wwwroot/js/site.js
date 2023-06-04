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
