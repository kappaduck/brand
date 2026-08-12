function init() {
  const body = document.getElementById('quack-app');

  document.querySelectorAll('input[name="theme"]').forEach(function (el) {
    el.addEventListener('change', function () {
      if (el.checked) {
        apply(el.value);
      }
    });
  });

  apply('dark');
  document.querySelector('#theme-dark').checked = true;

  function apply(theme) {
    body.className = `theme-${theme}`;
  }
}

init();
