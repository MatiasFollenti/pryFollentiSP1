# pryFollentiSP1
SP1- ejercicios
El administrador de Autocor, un negocio de venta de repuestos, le ha solicitado a usted,
en calidad de pasante, el desarrollo de una aplicación para almacenar en un archivo de
texto los repuestos que comercializa y, luego, poder consultar el precio de venta de los
repuestos por su marca y origen. Al iniciar la aplicación se abre un formulario para el
ingreso del repuesto, los datos solicitados de cada uno de ellos en la interfaz son los
siguientes:
● El código del repuesto de tipo string en una caja de texto,
● El nombre del repuesto de tipo string en una caja de texto,
● El nombre de la marca del repuesto que se selecciona de un combobox, el
negocio trabaja con tres marcas de repuestos,
● El precio del repuesto de tipo decimal en una caja de texto
● El origen del repuesto (nacional o importado), que se elige de botones de opción
contenidos en un groupbox.
El formulario para el ingreso del repuesto contiene cuatro botones de comando
denominados Aceptar, Cancelar, Consultar y Salir.
El botón de comando aceptar se habilita si los datos del repuesto son correctos
y, al ser pulsado, graba todos los datos del repuesto en el archivo de texto, no
Laboratorio de Programación II 12
permite grabar códigos de repuestos repetidos, pero si esto ocurre informa el
error al usuario.
● El botón cancelar inicializa las cajas de texto y establece el botón de opción
nacional como predeterminado, éste es el estado inicial de la interfaz.
● El botón consultar abre un nuevo formulario para la consulta de repuestos por
los criterios de marca y origen.
● El botón salir finaliza la aplicación.
El formulario para la consulta de repuestos permite seleccionar la marca de un
combobox y de un groupbox con tres botones de opción, el origen del repuesto,
nacional, importado o ambos orígenes.
Una vez elegido el criterio de los datos a consultar y al pulsar un botón de comando, se
visualizan en una grilla todos los repuestos que cumplen con los datos seleccionados.
De cada repuesto se lista su código, el nombre del repuesto, la marca del repuesto, el
origen del repuesto y precio de venta. Los datos se deben mostrar ordenados
alfabéticamente por el nombre del repuesto de menor a mayor.
