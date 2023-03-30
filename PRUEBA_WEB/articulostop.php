<?php
// Conectarse a la base de datos
$serverName = "DMLAP\SQLEXPRESS";
$connectionInfo = array("Database" => "examen", "UID" => "pru", "PWD" => "redes_01");
$conn = sqlsrv_connect($serverName, $connectionInfo);

// Verificar si la conexión es exitosa
if ($conn === false) {
    die(print_r(sqlsrv_errors(), true));
}

// Consultar las ventas por artículo
$query = "SELECT dbo.Productos.Titulo, SUM(dbo.Ventas.CantidadVendida) AS total_ventas
FROM dbo.Productos
JOIN Ventas ON Productos.IDProductos = Ventas.IDProductos
GROUP BY Productos.Titulo
HAVING SUM(dbo.Ventas.CantidadVendida) > 540
ORDER BY total_ventas DESC;";

$stmt = sqlsrv_query($conn, $query);

// Crear un array para almacenar los resultados
$resultados = array();

// Recorrer los resultados de la consulta y guardarlos en el array


while ($row = sqlsrv_fetch_array($stmt, SQLSRV_FETCH_ASSOC)) {
    $resultados[] = array(
        'Titulo' => $row['Titulo'],
        'total_ventas' => $row['total_ventas']
    );
}

// Liberar los recursos de la consulta y la conexión a la base de datos
sqlsrv_free_stmt($stmt);
sqlsrv_close($conn);

// Convertir los resultados a formato JSON y enviarlos como respuesta
header('Content-Type: application/json');
echo json_encode($resultados);
?>