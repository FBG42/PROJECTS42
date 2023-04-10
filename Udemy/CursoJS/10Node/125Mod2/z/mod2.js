// const Cachorro = require('../B/C/D/mod')
const path = require('path');
const Cachorro = require(path.resolve(__dirname, '..', 'B', 'C', 'D', 'mod.js'))


module.exports = Cachorro