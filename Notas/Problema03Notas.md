## Guía de Funcionalidades Modernas en C#

Esta guía describe herramientas del lenguaje C# que ayudan a optimizar rendimiento y legibilidad, comparándolas con enfoques tradicionales.

---

## 1. Bloques Implícitos vs. Explícitos (Single-line Statements)

C# permite omitir las llaves `{ }` cuando un `if`, `for` o estructura similar contiene una sola sentencia.

**Lo que reemplaza**
Bloques de código con llaves innecesarias para operaciones simples.

**Funcionamiento interno**
El compilador identifica la primera instrucción terminada en `;` después de un `for` o `if`. Todo lo que aparece antes de ese punto y coma se considera el cuerpo de la instrucción.

**Ventaja**
Reduce el ruido visual y facilita la lectura en algoritmos donde la lógica es directa.

```csharp
// Forma compacta
for (int i = 2; i <= limite; i++) esPrimo[i] = true;

// Forma tradicional
for (int i = 2; i <= limite; i++)
{
    esPrimo[i] = true;
}
```

---

## 2. Arreglos de Tamaño Fijo (`Array`) vs. Listas Dinámicas (`List`)

La declaración `bool[] esPrimo = new bool[n];` define una estructura de datos de tamaño fijo.

**Lo que reemplaza**
El uso de `List<bool>` cuando el tamaño de la colección ya es conocido.

**Funcionamiento interno**

* **Memoria (RAM):** Se reserva un bloque contiguo de memoria.
* **Localidad de referencia:** El procesador puede predecir la ubicación del siguiente elemento.
* **Acceso:** La dirección se calcula directamente:

[
DireccionBase + (Indice \times TamañoDelTipo)
]

**Ventajas**

* Mayor velocidad de acceso.
* Menor sobrecarga de abstracción.
* Menor presión sobre el Garbage Collector al no requerir redimensionamiento.

---

## 3. `Array.Fill`: Inicialización de Alto Rendimiento

Disponible desde **.NET Core 2.0** y versiones posteriores de .NET.

**Lo que reemplaza**
El uso de un ciclo `for` para inicializar manualmente los elementos de un arreglo.

**Funcionamiento interno**
Utiliza operaciones optimizadas de memoria (similares a `memset`) y, en muchos casos, instrucciones SIMD que permiten escribir múltiples datos en memoria con una sola operación.

**Ventaja**
Alto rendimiento, especialmente en arreglos grandes.

```csharp
Array.Fill(esPrimo, true);
```

---

## 4. Estrategia del Índice (`+1`) y Valores por Defecto

Al declarar:

```csharp
bool[] esPrimo = new bool[limiteMaximo + 1];
```

**Motivo**

Permite que el índice coincida directamente con el número evaluado.
Por ejemplo, el número 100 se evalúa en el índice `100`, evitando errores de desfase.

**Valores por defecto**

En C#, los tipos primitivos se inicializan automáticamente.
Para `bool`, el valor inicial es `false` (representado como `0x00` en memoria).

**Estrategia algorítmica**

En algoritmos como la criba de números primos, suele ser más eficiente inicializar todo en `true` y marcar como `false` los números compuestos.

---

## 5. Casting Numérico Preciso: `(int)` vs `Convert`

Ejemplo:

```csharp
int raiz = (int)Math.Sqrt(n);
```

**Lo que reemplaza**

* `Convert.ToInt32()`
* `int.Parse()`

**Funcionamiento interno**

* El **casting `(int)`** descarta directamente la parte fraccionaria.
* `Convert` realiza validaciones adicionales (redondeo, manejo de nulos), lo que implica mayor costo computacional.

**Ventaja**

Mayor eficiencia cuando se necesita únicamente la parte entera de un cálculo.

---

## Resumen: Aplicación en la Criba de Eratóstenes

Al calcular números primos hasta 1,000,000:

* `Array` garantiza memoria contigua y estable.
* `Array.Fill` inicializa la estructura rápidamente.
* `(int)Math.Sqrt(n)` determina el límite del algoritmo con mínima sobrecarga.
* `for` sin llaves simplifica la lectura del flujo lógico.

En conjunto, estas prácticas permiten implementar algoritmos numéricos más eficientes y con mayor claridad estructural.
