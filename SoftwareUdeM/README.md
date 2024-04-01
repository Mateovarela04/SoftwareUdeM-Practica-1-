	Práctica I - Lenguajes de Programación y Código Limpio

Descripción:

El objetivo de este proyecto es desarrollar una aplicación de consola o interfaz gráfica para
la gestión de procesos estudiantiles en la Universidad de Medellín. Este sistema permitirá a
los usuarios (estudiantes, profesores, y administrativos) interactuar con diferentes aspectos
del entorno académico, tales como inscripciones a cursos, gestión de notas, y consulta de
horarios. La aplicación debe ser desarrollada utilizando los principios de la programación
orientada a objetos (POO), tales como abstracción, encapsulamiento, herencia, y
polimorfismo, además de aplicar restricciones complejas para garantizar la integridad y
seguridad de los datos.

Requisitos y Funcionalidades

● Modelado de Usuarios: El sistema debe tener una jerarquía de clases para
representar diferentes tipos de usuarios (estudiantes, profesores, administrativos).
Esto debería incluir herencia para compartir atributos y métodos comunes, y
polimorfismo para comportamientos específicos de cada tipo de usuario.

● Autenticación y Autorización: Implementar un sistema de autenticación para los
usuarios, con encapsulamiento de la información sensible. Debe haber restricciones
sobre qué acciones puede realizar cada tipo de usuario en el sistema.

● Gestión de Cursos: Crear clases para manejar la inscripción de estudiantes en
cursos, incluyendo pre-requisitos y co-requisitos como restricciones complejas. Debe
haber funcionalidades para agregar, eliminar y listar cursos, así como inscribir y
desinscribir estudiantes.

● Gestión de Horarios: El sistema debe permitir consultar los horarios de clases,
examinando la disponibilidad de aulas y evitando solapamientos. Esto requerirá el
uso de algoritmos para la asignación de recursos y la gestión de conflictos.

● Gestión de Notas: Implementar un sistema para que los profesores puedan
ingresar las notas de los estudiantes. Debe haber restricciones para asegurar que
solo los profesores asignados a un curso puedan modificar las notas de dicho curso.

● Interfaz de Usuario: Diseñar una interfaz de usuario intuitiva que permita a los
diferentes tipos de usuarios interactuar fácilmente con el sistema. Esto puede ser
una aplicación de consola con un menú de opciones o una interfaz gráfica básica.

● Persistencia de Datos: Los datos deben ser almacenados y recuperados de una
manera que garantice su persistencia entre sesiones. Esto puede ser a través de
archivos planos, bases de datos en memoria, o sistemas de bases de datos más
complejos.

● Documentación: Modelar el sistema usando un diagrama de clases.	