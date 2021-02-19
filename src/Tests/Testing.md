# Universidad Católica del Uruguay

<img src="https://ucu.edu.uy/sites/all/themes/univer/logo.png">

## Facultad de Ingeniería y Tecnologías

### Programación II - Examen Diciembre 2020

# Encuentros de Tierra Media "El Juego Final"

![Banner](./banner.png)


## Sugerencias para los casos de test

El propósito de este documento es de ayudarte con la identificación de algunos de los casos de test que deberes desarrollar.

🥉1. Cuando un character tiene vida 0, su propiedad `isDead` es verdadera; de lo contrario es falsa.

🥈2. Al crear un personaje y asignarle un item de ataque  su poder de ataque aumenta de forma acorde.

🥈3. Al crear un personaje y asignarle un item de defensa su poder de defensa aumenta de forma acorde.

🥈4. Al quitarle el item de ataque su poder de ataque se reduce de forma acorde.

🥈5. Al quitarle el item defensa su poder de defensa reduce de forma acorde.

🥈6. Al crear un personaje y asignarle dos items de ataque, el poder de ataque es la suma de los poderes de ataque de ambos.

🥈7. Al crear un personaje y asignarle dos items de defensa, el poder de defensa la suma de los poderes de ataque de ambos.

🏅8. Al quitarle a un personaje un item que no tiene se debería lanzar una excepción.

🥈9. Cuando un personaje recibe un ataque, su vida disminuye según `poder de ataque - defensa del personaje`.

🥈10. Cuando un personaje recibe un ataque, su vida nunca puede ser menor que 0.

🥈11. Cuando un personaje recibe un ataque y su defensa es _mayor_ al ataque, su vida no se modifica.

🥈12. Cuando se da un encuentro de tipo intercambio entre dos personajes y un elemento, el emisor pierde el elemento y el receptor lo gana.

🏅13. Cuando se da un encuentro de tipo intercambio entre dos personajes y varios elementos, el emisor pierde todos los elementos y el receptor los gana.

🏅14. Cuando se da un encuentro de tipo intercambio entre dos personajes y un elemento que el emisor no tiene, se debería lanzar una excepción

🏅15. Cuando se da un encuentro de tipo combate entre dos personajes, la batalla debe tener el resultado esperado. **Aquí se generan varios casos de Test**, por ejemplo:

-   20.1. Si un personaje no tiene defensa ni ataque y el otro tiene ataque, el primero debe perder.
-   Etc.

💎16. Cuando se da un encuentro de tipo combate, el encuentro termina en el momento en que uno de los dos personajes muere. **Aquí también se generan varios tests**.

### Nota:
Algunos de estos puntos generan más de un test. Deberán identificar ustedes los casos a probar en cada uno de esos casos. 

> [<< Volver](../README.md)