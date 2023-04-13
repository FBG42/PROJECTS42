exports.middlewareGlobal = (request, response, next) => {
	response.locals.umaVariavelLocal = 'Este é o valor da variável local.'
	next();
}

exports.outroMiddleware = (request, response, next) => {
	next();
}
