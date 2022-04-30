document.addEventListener('DOMContentLoaded', () => {
    addEventListerToBtnRefreshUsersWithMoreInspetions();
    addEventListerToBtnRefreshUsersWithLessInspetions();
});

function addEventListerToBtnRefreshUsersWithMoreInspetions() {
    const btn = document.querySelector('#btnRefreshUsersWithMoreSatisfyingInspections');
    if (btn) {
        btn.addEventListener('click', async () => {
            const url = btn.getAttribute('data-url');
            await refreshUsersWithInspetions(url, btn);
        })
    }
}

function addEventListerToBtnRefreshUsersWithLessInspetions() {
    const btn = document.querySelector('#btnRefreshUsersWithLessSatisfyingInspections');
    if (btn) {
        btn.addEventListener('click', async () => {
            const url = btn.getAttribute('data-url');
            await refreshUsersWithInspetions(url, btn);
        })
    }
}

/**
 * 
 * @param {string} url
 * @param {HTMLElement} btn
 */
async function refreshUsersWithInspetions(url, btn) {
    btn.setAttribute('disabled', true);
    const response = await fetch(url, { method: 'GET' });
    const data = await response.json();
    if (response.ok) {
        if (data.ok) {
            if (data.moreSatisfying) {
                const container = document.querySelector('#containerUsersWithMoreSatisfyingInspections');
                container.innerHTML = data.html;
                btn.setAttribute('disabled', false);
            } else {
                const container = document.querySelector('#containerUsersWithLessSatisfyingInspections');
                container.innerHTML = data.html;
                btn.removeAttribute('disabled');
            }
        } else {
            btn.removeAttribute('disabled');
        }
    } else {
        btn.removeAttribute('disabled');
    }
}