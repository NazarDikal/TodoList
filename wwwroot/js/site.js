
    // Плавне перемикання вкладок
    document.addEventListener('DOMContentLoaded', function () {
        var tabs = document.querySelectorAll('.nav-link');

    tabs.forEach(function(tab) {
        tab.addEventListener('click', function () {
            var target = document.querySelector(tab.getAttribute('data-bs-target'));

            // Приховуємо всі вкладки
            var allTabs = document.querySelectorAll('.tab-pane');
            allTabs.forEach(function (tabPane) {
                tabPane.classList.remove('show', 'active');
            });

            // Показуємо обрану вкладку
            target.classList.add('show', 'active');
        });
        });
    });





