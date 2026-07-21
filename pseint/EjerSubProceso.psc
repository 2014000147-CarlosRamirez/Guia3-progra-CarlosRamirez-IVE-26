Algoritmo EjerSubProceso
	Dimension estudiantes[10,3]
	Definir opcion Como Entero
	
	Repetir
		Limpiar Pantalla
		Escribir "====== MENU ======"
		Escribir "1. Registrar"
		Escribir "2. Mostrar"
		Escribir "3. Actualizar"
		Escribir "4. Eliminar"
		Escribir "5. Salir"
		Leer opcion
		
		Segun opcion Hacer
			1:
				Limpiar Pantalla
				Escribir "===REGISTRAR ESTUDIANTES==="
				Registrar(estudiantes)
				Escribir "Presione cualquier tecla para continuar..."
				Esperar Tecla
			2:
				Limpiar Pantalla
				Escribir "===MOSTRAR ESTUDIANTES==="
				MostrarE(estudiantes)
				Escribir "Presione cualquier tecla para continuar..."
				Esperar Tecla
			3:
				Limpiar Pantalla
				Escribir "===ACTUALIZAR ESTUDIANTES==="
				Actualizar(estudiantes)
				Escribir "Presione cualquier tecla para continuar..."
				Esperar Tecla
			4:
				Limpiar Pantalla
				Escribir "===ELIMINAR ESTUDIANTES==="
				Eliminar(estudiantes)
				Escribir "Presione cualquier tecla para continuar..."
				Esperar Tecla
		FinSegun
	Hasta Que opcion = 5
FinAlgoritmo

//Método registrar estudiantes
SubProceso Registrar(estudiantes)
	Definir i Como Entero
	
	Para i=1 Hasta 2
		Si estudiantes[i,1]="" Entonces
			Escribir "Codigo:"
			Leer estudiantes[i,1]
			Escribir "Nombre:"
			Leer estudiantes[i,2]
			Escribir "Edad:"
			Leer estudiantes[i,3]
			Escribir "Estudiante registrado."
		FinSi
	FinPara
	
	Escribir "Matriz llena."
FinSubProceso

//Método Mostrar estudiantes
SubProceso MostrarE(estudiantes)
	Definir i Como Entero
	
	Escribir "CODIGO   NOMBRE   EDAD"
	Para i=1 Hasta 10
		Si estudiantes[i,1]<>"" Entonces
			Escribir estudiantes[i,1],"      ",estudiantes[i,2],"      ",estudiantes[i,3]
		FinSi
	FinPara
FinSubProceso

//Método Actualizar estudiantes
SubProceso Actualizar(estudiantes)
	Definir i Como Entero
	Definir codigo Como Cadena
	
	Escribir "Codigo a buscar:"
	Leer codigo
	
	Para i=1 Hasta 10
		Si estudiantes[i,1]=codigo Entonces
			Escribir "Nuevo nombre:"
			Leer estudiantes[i,2]
			Escribir "Nueva edad:"
			Leer estudiantes[i,3]
			Escribir "Registro actualizado."
		FinSi
	FinPara
FinSubProceso

//Método Eliminar estudiantes
SubProceso Eliminar(estudiantes)
	Definir i Como Entero
	Definir codigo Como Cadena
	
	Escribir "Codigo a eliminar:"
	Leer codigo
	
	Para i=1 Hasta 10
		Si estudiantes[i,1]=codigo Entonces
			estudiantes[i,1]=""
			estudiantes[i,2]=""
			estudiantes[i,3]=""
			Escribir "Registro eliminado."
		FinSi
	FinPara
FinSubProceso