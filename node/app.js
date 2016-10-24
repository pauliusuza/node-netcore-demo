'use strict';

const edge = require('edge');
const path = require('path');

const dll = (library) => { return path.resolve(__dirname, '../bin/Debug/netcoreapp1.0/' + library); };
const getPerson = edge.func(dll('nodenet.dll'));

getPerson(null, function (error, result) {
    if (error) throw error;
    console.log(result);
});