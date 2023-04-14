exports.middlewareGlobal = (request, response, next) => {
	response.locals.umaVariavelLocal = 'Este é o valor da variável local.'
	next();
}

exports.outroMiddleware = (request, response, next) => {
	next();
}


exports.checkCsrfError = (error, request, response, next) => {
	if (error) {
		return response.render('404')
	}

	next();
}

exports.csrfMiddleware = (request, response, next) => {
	response.locals.csrfToken = request.csrfToken();
	next();
}