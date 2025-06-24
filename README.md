# Aplicación de Escritorio CRUD de Productos

## Descripción
Este proyecto es una aplicación de escritorio desarrollada con **Flutter** como FrontEnd, que permite realizar operaciones **CRUD** sobre una base de datos de productos a través de una API desarrollada en **.NET** utilizando **C#**.

La aplicación cuenta con una interfaz sencilla e intuitiva para que los usuarios puedan gestionar productos de forma fácil y rápida.

---

## Requisitos

- La aplicación de escritorio está desarrollada en **Flutter**.
- La API está desarrollada en **C#** utilizando **.NET**.
- La interfaz debe permitir realizar las operaciones CRUD sobre los productos.
- La conexión a la base de datos se realiza a través de la API.
- La base de datos contiene la siguiente estructura para los productos:

| Campo       | Tipo     | Descripción              |
|-------------|----------|--------------------------|
| `id`        | int      | Identificador único      |
| `nombre`   | string   | Nombre del producto       |
| `descripcion` | string | Descripción del producto  |
| `precio`    | decimal  | Precio del producto       |
| `stock`     | int      | Cantidad disponible       |

---

## Funcionalidades de la API

La API implementa las siguientes funciones para interactuar con la base de datos:

- `get_productos()`: Retorna todos los productos disponibles.
- `get_producto(id)`: Retorna un producto específico según su ID.
- `crear_producto(producto)`: Crea un nuevo producto en la base de datos.
- `actualizar_producto(id, nuevo_producto)`: Actualiza un producto existente por su ID.
- `eliminar_producto(id)`: Elimina un producto de la base de datos por su ID.

---

## Instalación y Ejecución

### Backend (.NET API)

1. Clonar el repositorio.
2. Abrir el proyecto en Visual Studio o tu IDE favorito.
3. Restaurar paquetes y compilar el proyecto.
4. Configurar la cadena de conexión a la base de datos.
5. Ejecutar la API (por ejemplo, con `dotnet run`).

### Frontend (Flutter)

1. Instalar Flutter SDK y dependencias.
2. Navegar a la carpeta del proyecto Flutter.
3. Ejecutar `flutter pub get` para obtener dependencias.
4. Configurar la URL base de la API en la aplicación.
5. Ejecutar la aplicación en tu plataforma de preferencia (Windows, macOS, Linux).

---

## Tecnologías Utilizadas

- **Flutter**: Desarrollo de la aplicación de escritorio.
- **.NET (C#)**: Desarrollo de la API backend.
- **Base de datos**: Sistema de gestión de base de datos relacional (a definir).

---

## Contribuciones

Las contribuciones son bienvenidas. Por favor, abre un *issue* o un *pull request* para sugerir mejoras o reportar errores.

---

## Licencia

Este proyecto está bajo la licencia MIT. Consulta el archivo [LICENSE](LICENSE) para más detalles.


