# examen1

Pequeña app de **consola en C#** para practicar POO, interfaces, validación y manejo de excepciones.  
Calcula la **nota final** de un alumno a partir de tres parciales y muestra un **mensaje** según el rango.

## 🎯 Objetivos del ejercicio
- Definir clases: `Alumno`, `Asignatura`, `Matricula`.
- Definir e implementar una **interfaz**: `ICalculoNota` con `CalcularNotaFinal()`.
- Implementar una **sobrecarga** de método: `CalcularNotaFinal(double n1, double n2, double n3)`.
- Validar reglas de negocio y **lanzar excepciones** (`throw`) cuando no se cumplan.
- Leer datos desde consola y manejar errores con **try/catch**.
- Mostrar resultados calculando de **dos maneras** (por interfaz y por sobrecarga).

## 📐 Reglas de negocio
- `n1 + n2 ≤ 30`
- `n3 ≤ 40`
- Rango de mensajes (según nota final, 0–100):
  - `≤ 59` → **Reprobado**
  - `60–79` → **Bueno**
  - `80–89` → **Muy Bueno**
  - `90–100` → **Sobresaliente**

## 🧱 Estructura
```
examen1/
 ├── Alumno.cs
 ├── Asignatura.cs
 ├── ICalculoNota.cs
 ├── Matricula.cs
 └── Program.cs
```

## 🛠️ Requisitos
- **.NET SDK 8.0** (o 6.0+)
- Windows, macOS o Linux
- (Opcional) Visual Studio / VS Code + C# extension

## 🚀 Ejecutar
Desde la carpeta del proyecto:
```bash
dotnet build
dotnet run
```

## 🖥️ Uso
El programa solicita tres notas:
```
Ingrese las 3 notas parciales (n1, n2, n3):
n1 (recuerde que n1 + n2 <= 30): 15
n2 (recuerde que n1 + n2 <= 30): 10
n3 (máximo 40): 30
```
Salida esperada (resumen abreviado):
```
Notas: n1=15, n2=10, n3=30

Cálculo por interfaz (sin parámetros):
Nota final: 55 | Mensaje: Reprobado

Cálculo por método sobrecargado (con parámetros):
Nota final: 55 | Mensaje: Reprobado
```

## 🧪 Pruebas rápidas
- ✅ **Caso válido**: `n1=20, n2=10, n3=40` → 70 → **Bueno**
- ✅ **Borde**: `n1=30, n2=0, n3=40` → 70 → **Bueno**
- ❌ **Falla**: `n1=25, n2=10` → **excepción** (n1+n2>30)
- ❌ **Falla**: `n3=41` → **excepción** (n3>40)
- ❌ **Falla**: texto en vez de número → **FormatException** (capturada)

## 🧩 Detalles técnicos
- `Matricula` implementa `ICalculoNota`:
  - `CalcularNotaFinal()` suma la lista `NotasParciales` (interfaz).
  - `CalcularNotaFinal(n1, n2, n3)` es la **sobrecarga**.
- `ValidarNotas(n1, n2, n3)` lanza `ArgumentException` si no se cumplen las reglas.
- `Program.cs` controla el flujo, pide datos, captura `FormatException`/`ArgumentException` y muestra ambos cálculos.

## 🔧 Personalización
- Cambia los datos de `Alumno` y `Asignatura` en `Program.cs`.
- Ajusta los rangos de mensajes en `ObtenerMensajeNota(double notaFinal)` si lo requiere tu docente.

## ⚠️ Errores comunes
- **Separador decimal**: usa el de tu configuración regional (`,``.`).
- **Namespace**: asegúrate que todos los archivos usan `namespace examen1` para compilar sin conflictos.

---

> Hecho para la clase **Programación II**
