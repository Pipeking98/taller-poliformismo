using TallerPoliformismo.clases;

EmpleadoPorHoras empleado1 = new EmpleadoPorHoras(
    "Nataly Garavito",
    "Empleado por horas",
    170,
    20000
);
empleado1.MostrarInformacion();

EmpleadoPorHoras empleado2 = new EmpleadoPorHoras(
    "Andres Lopez",
    "Empleado por horas",
    120,
    20000
);

empleado2.MostrarInformacion();

EmpleadoPorComision empleado3 = new EmpleadoPorComision(
    "Camila Rodriguez",
    "Empleado por comisión",
    500000,
    1000000
);
empleado3.MostrarInformacion();

EmpleadoPorComision empleado4 = new EmpleadoPorComision(
    "Sofia Martinez",
    "Empleado por comisión",
    500000,
    0
);
empleado4.MostrarInformacion();

EmpleadoTiempoCompleto empleado5 = new EmpleadoTiempoCompleto(
    "Juan Perez",
    "Empleado tiempo completo",
    3000000
);
empleado5.MostrarInformacion();