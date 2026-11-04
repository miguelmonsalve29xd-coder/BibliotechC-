# 📚 Sistema de Gestión de Biblioteca en C#

## Descripción del proyecto

Este proyecto consiste en una aplicación de consola desarrollada en C# que simula un sistema de gestión de biblioteca.

Su objetivo es aplicar los fundamentos de programación en C#, utilizando métodos estáticos, estructuras condicionales, ciclos, menús interactivos y validaciones básicas.

El sistema permite navegar por diferentes módulos para simular la administración de libros, usuarios, préstamos, búsquedas, reportes y gestión de datos.

**Importante:** Este proyecto tiene fines académicos. Las operaciones se representan mediante mensajes en consola; no se implementa una base de datos, almacenamiento real ni operaciones CRUD completas.

## 🎯 Objetivos

- Aplicar la sintaxis básica del lenguaje C#.
- Crear y utilizar métodos estáticos.
- Implementar menús mediante `switch` y `case`.
- Utilizar estructuras condicionales `if` y ciclos `while`, `do-while` y `for`.
- Validar entradas del usuario.
- Organizar el código en funciones.
- Aplicar Git Flow para el control de versiones.

## 🛠️ Tecnologías utilizadas

- **Lenguaje:** C#
- **Plataforma:** .NET
- **Tipo de aplicación:** Consola
- **Editor:** Visual Studio Code
- **Control de versiones:** Git
- **Repositorio remoto:** GitHub

## 📋 Funcionalidades

El programa cuenta con un menú principal con seis módulos:

### 1. Gestión de libros

Permite simular las siguientes operaciones:

- Registrar libros.
- Listar todos los libros.
- Consultar libros disponibles.
- Consultar libros prestados.
- Ver detalles de un libro por ID o ISBN.
- Actualizar título, autor, año o categoría.
- Eliminar libros, considerando la validación de préstamos activos.

### 2. Gestión de usuarios

Incluye las siguientes opciones:

- Registrar usuarios.
- Listar usuarios.
- Consultar detalles por ID o documento.
- Actualizar nombres y datos de contacto.
- Activar o desactivar usuarios.
- Eliminar usuarios, considerando la validación de préstamos activos.

### 3. Gestión de préstamos

Permite simular:

- Crear préstamos.
- Validar la existencia y disponibilidad del libro.
- Validar la existencia y el estado del usuario.
- Listar todos los préstamos.
- Consultar préstamos activos.
- Consultar préstamos cerrados.
- Ver detalles de un préstamo.
- Registrar devoluciones.
- Eliminar préstamos según las reglas establecidas.

### 4. Búsquedas y reportes

Incluye:

- Buscar libros por título, autor, ID o categoría.
- Buscar usuarios por nombre o ID.
- Consultar reportes por usuario.
- Consultar reportes por libro.
- Consultar préstamos vencidos.
- Generar un resumen general del sistema.

### 5. Guardar y cargar datos

Contiene las siguientes opciones:

- Simular el guardado de datos.
- Simular la carga de datos.
- Reiniciar datos con confirmación.
- Validar las respuestas de confirmación.

### 6. Salir del programa

Antes de finalizar, el sistema pregunta si se desea guardar la información:

- **S:** Ejecuta la función de guardado simulado y termina el programa.
- **N:** Sale sin guardar.
- **Otra respuesta:** Solicita nuevamente una respuesta válida.

## 📁 Estructura del proyecto

```text
BibliotecaConsola/
│
├── Program.cs
├── BibliotecaConsola.csproj
├── README.md
└── .gitignore
```

La lógica del proyecto se encuentra organizada mediante métodos estáticos dentro del archivo `Program.cs`.

## ⚙️ Requisitos para ejecutar el proyecto

Antes de comenzar, debes tener instalado:

- .NET SDK.
- Visual Studio Code (recomendado).
- Git.

## ▶️ Instalación y ejecución

1. Clonar el repositorio:

```bash
git clone URL_DEL_REPOSITORIO
```

2. Ingresar a la carpeta:

```bash
cd BibliotechC#
```

3. Ejecutar el proyecto:

```bash
dotnet run
```

También puedes compilarlo con:

```bash
dotnet build
```

## 🌿 Estrategia de trabajo: Git Flow

Para organizar el desarrollo se utilizó una estructura de ramas basada en Git Flow.

### Ramas principales

- `main`: contiene la versión final del proyecto.
- `develop`: integra las funcionalidades desarrolladas.

### Ramas de funcionalidades

| Rama | Funcionalidad |
|---|---|
| `feature/project-bootstrap` | Configuración inicial del proyecto |
| `feature/main-menu-navigation` | Menú principal y navegación |
| `feature/books-menu` | Gestión de libros |
| `feature/users-menu` | Gestión de usuarios |
| `feature/loans-menu` | Gestión de préstamos |
| `feature/search-reports-menu` | Búsquedas y reportes |
| `feature/persistence-menu` | Guardar, cargar y reiniciar datos |
| `feature/exit-flow` | Confirmación de salida |

Cada funcionalidad se desarrolló en su propia rama y posteriormente se integró en `develop`. Al finalizar, se integra `develop` en `main`.

## 📚 Conceptos de C# aplicados

Durante el desarrollo se trabajaron los siguientes conceptos:

- Métodos estáticos.
- Método principal `Main()`.
- Variables y tipos de datos.
- Entrada y salida por consola.
- Condicionales `if` y `else`.
- Estructura `switch` y `case`.
- Ciclos `while`, `do-while` y `for`.
- Validación de datos con `int.TryParse()`.
- Uso de `Console.ReadLine()`.
- Organización y reutilización de métodos.

## 👨‍💻 Autor

**Miguel Angel Monsalve Henao**

Aprendiz del programa Análisis y Desarrollo de Software (ADSO) – SENA.

## 📝 Contexto académico

Proyecto desarrollado como parte de la actividad de formación:

**GA-220501097-04-AA1 – EV06: Aplicación de la sintaxis básica de C# – Funciones.**

## 📌 Estado del proyecto

Proyecto académico desarrollado con fines de aprendizaje y práctica de programación en C#.

