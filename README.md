<!--Titulo principal-->
<div id="user-content-toc">
  <ul align="center">
    <summary>
      <!--Titulo-->
      <h2 style="display: inline-bloc">guestlist-manager-cli-csharp</h2>
      <br>
      <!--Divizor horizontal (gradiant)-->
      <img src="https://user-images.githubusercontent.com/73097560/115834477-dbab4500-a447-11eb-908a-139a6edaec5c.gif">
    </summary>
  </ul>
</div>

<div id="user-content-toc">
  <!--Caso de estudio-->
  <h3 align="center">Objetivo</h3>
  <p align="justify">
    Implementar operaciones CRUD (Create, Read, Update, Delete) con Visual C# .NET y mongoDB como base de datos no relacional.
  </p>
</div>

<div id="user-content-toc">
  <!--Caso de estudio-->
  <h3 align="center">Herramienta para utilizar</h3>
  <p align="justify">
    Visual C# .NET 2019+ y MongoDB Compass Community base de datos NoSQL
  </p>
</div>

<div>
  <!--Caso de estudio-->
  <div>
    <p>
      <h3 align="center">Crear una aplicación de Consola Visual C# .NET</h3>
    </p>
    <ul>
      <li>Abrir Visual Studio .NET y elegir Crear Nuevo Proyecto C# tipo Consola.</li>
      <pre><code>En los combos desplegables superiores, elegir:
C# - All Platforms – Console</code></pre>
<pre><code>Luego C# Console App (.NET Core) y botón Next</code></pre>
<pre><code>Nombre del proyecto: guestlist-manager-cli-csharp 
Ubicación: elegir una carpeta de trabajo.</code></pre>
<pre><code>Se crea el proyecto y se abre la aplicación principal.</code></pre>
    </ul>
  </div>
</div>

<div>
  <!--Caso de estudio-->
  <div>
    <p>
      <h3 align="center">Instalar MongoDB C#/.NET Driver</h3>
    </p>
    <ul>
      <li>Descargar mongoDB C# .NET Driver</li>
      <li>Crear la interfaz entre la aplicación y mongoDB.<br>
          Instalar el driver a través de Nuget.</li>
      <pre><code>Ir a https://docs.mongodb.com/drivers/csharp</code></pre>
      <pre><code>Ir a “Tools-> Nuget Package Manager -> Package Manager Console”</code></pre>
      <pre><code>En la ventana inferior llamada Package Manager Console escribir: 
PM> Install-Package MongoDB.Driver -version 2.10.3 &lt;enter&gt;</code></pre>
    </ul>
  </div>
</div>

<div>
  <!--Caso de estudio-->
  <div>
    <p>
      <h3 align="center">Crear clases Instanciables</h3>
    </p>
    <p>En la Ventana Solution Explorer</p>
    <pre><code>clic derecho -> Add -> New Item -> Visual C# Class</code></pre>
    <ul>
      <li>Crear la clase GuestModel.cs con el siguiente código:</li>
    </ul>
    <div>
      <pre><code>using MongoDB.Bson.Serialization.Attributes; 
using System;
<enter></enter>
namespace guestlist_manager_cli_csharp 
{ 
  public class GuestModel 
  { 
    [BsonId]  // _id 
    public Guid Id { get; set; } 
    public string Email { get; set; }</code></pre>
    </div>
  </div>
</div>

[Ver código completo](./guestlist-manager-cli-csharp/guestlist-manager-cli-csharp/GuestModel.cs)

<div>
  <!--Caso de estudio-->
  <div>
    <ul> 
      <li>Crear la clase MongoHelper.cs con el siguiente código:</li>
    </ul>
    <div>
      <pre><code>using MongoDB.Driver; 
using MongoDB.Bson; 
using System; 
using System.Collections.Generic;
<enter></enter>
namespace guestlist_manager_cli_csharp 
{ 
  public class MongoHelper 
  { 
    private IMongoDatabase db;
    <enter></enter>
    public MongoHelper(string connectionString, string databaseName) 
    { </code></pre>
    </div>
  </div>
</div>

[Ver código completo](./guestlist-manager-cli-csharp/guestlist-manager-cli-csharp/MongoHelper.cs)

<div>
  <!--Caso de estudio-->
  <div>
    <ul> 
      <li>Crear la clase ConsoleTable.cs con el siguiente código: </li>
    </ul>
    <div>
      <pre><code>using System.Collections.Generic; 
using System.Linq; 
<enter></enter>
namespace guestlist_manager_cli_csharp 
{ 
  public class ConsoleTable 
  {   </code></pre>
    </div>
  </div>
</div>

[Ver código completo](./guestlist-manager-cli-csharp/guestlist-manager-cli-csharp/ConsoleTable.cs)

<div>
  <!--Caso de estudio-->
  <div>
    <ul> 
      <li>Crear la clase DialogHelper.cs con el siguiente código:</li>
    </ul>
    <div>
      <pre><code>using System; 
using System.Collections.Generic;
<enter></enter>
namespace guestlist_manager_cli_csharp 
{ 
  public static class DialogHelper 
  { 
    public static int ShowMainMenu() 
    { </code></pre>
    </div>
  </div>
</div>

[Ver código completo](./guestlist-manager-cli-csharp/guestlist-manager-cli-csharp/DialogHelper.cs) 

<div>
  <!--Caso de estudio-->
  <div>
    <p>
      <h3 align="center">Aplicación principal </h3>
    </p>
    <ul>
      <li>Modificar el método main de la aplicación de consola llamado Program.cs</li>
    </ul>
    <div>
      <pre><code>using System;
<enter></enter>
namespace guestlist_manager_cli_csharp 
{ 
  class Program 
  { 
    static void Main(string[] args) 
    { </code></pre>
    </div>
  </div>
</div>

[Ver código completo](./guestlist-manager-cli-csharp/guestlist-manager-cli-csharp/Program.cs)

<div>
  <!--Caso de estudio-->
  <div>
    <p>
      <h3 aling="center">Ejecutar la aplicación de consola</h3>
    </p>
    <ul>
      <li>Realizar operaciones CRUD</li>
    </ul>
  </div>
</div>
