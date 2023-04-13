exports.middlewareGlobal = (request, response, next) => {
	response.locals.umaVariavelLocal = 'Este é o valor da variável local.'
	next();
}

exports.outroMiddleware = (request, response, next) => {
	next();
}


exports.checkCsrfError = (error, request, response, next) => {
	if (error && error.code === 'EBADCSRFTOKEN') {
		return response.render('404')
	}
}

exports.csrfMiddleware = (request, response, next) => {
	response.locals.csrfToken = request.csrfToken();
	next();
}