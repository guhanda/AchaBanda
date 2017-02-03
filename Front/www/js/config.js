(function (gl) {

    "use strict";

    var baseURLApi = "http://localhost:53478/";

    gl.config = {
        urls:{
            loginAPI: baseURLApi + "/api/Usuario/:id",
            buscarInstrumento: baseURLApi + '/api/Instrumento/:id',
            buscarEstilo: baseURLApi + '/api/Estilo/:id',
            cadastrarUsuarioInstrumento : baseURLApi + '/api/UsuarioInstrumento',
            cadastrarUsuarioEstilo : baseURLApi + '/api/UsuarioEstilo',
        }
    };

})(window);