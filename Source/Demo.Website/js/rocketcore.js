$('.js-submit-fruit').click(function submitFruit() {
	var data = {};

	$('.js-fruit-form').find('.js-fruit-form-input').each(function () {
		var inputName = this.name;
		var inputValue = this.value;

		console.log(inputName + ': ' + inputValue);
		data[inputName] = inputValue;
	});

	$.post('api/fruitrepository/create/', data, function (response) {
		$('.js-fruit-form').find((response.created) ? '.js-fruit-form-success' : '.js-fruit-form-fail').show();

		if (response.created) {
			$.get(window.location.href, function (response) {
				$('.js-all-fruit').html($(response).find('.js-all-fruit').html());
				$('.js-top-fruit').html($(response).find('.js-top-fruit').html());
			});
		}
	});

	console.log('Submitted');
});