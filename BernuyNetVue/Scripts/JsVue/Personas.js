new Vue({
            el: "#app",
            data: {
                listaPersonas: null,
                misDatos: null
            },
            methods: {
                traerAxios: function () {
                    axios.get('/Home/GetPersonas/').then(function (response) {
                        if (response.data.Error == false) {
                            this.listaPersonas = response.data.personaLista
                        } else {
                            alert("Ocurrió un error, revisar el console log para mas detalles...");
                            console.error(data.Mensaje);
                        }      
                    }.bind(this)).catch(function (error) {
                        console.log(error);
                    });
                },
                traerJquery: function () {
                    $.get('/Home/GetPersonas/', function (data) {
                        if (data.Error == false) {
                            this.listaPersonas = data.personaLista
                        } else {
                            alert("Ocurrió un error, revisar el console log para mas detalles...");
                            console.error(data.Mensaje);
                        }   
                    }.bind(this));
                },
                limpiarLista: function () {
                    this.listaPersonas = null;
                }
            },
            computed: {
            },
            created: function () {
                //this.traerAxios();
                //this.traerJquery();
            },
            mounted: function () {
            }
        });