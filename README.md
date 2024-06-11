# Código que Si cumple con OCP, ISP y DIP:
## Explicación de las mejoras:
* OCP (Open/Closed Principle): La clase TransporteService no necesita ser modificada para añadir nuevos tipos de transporte.
  Solo necesita recibir nuevas implementaciones de ITransporte.
* ISP (Interface Segregation Principle): La interfaz ITransporte solo tiene métodos necesarios para todas las implementaciones de transporte,
  mientras que la interfaz IVolador se usa para transportes que pueden volar.
* DIP (Dependency Inversion Principle): TransporteService depende de abstracciones (ITransporte y IRepository<ITransporte>) en lugar de implementaciones concretas.
  Esto hace que el código sea más flexible y fácil de mantener.
