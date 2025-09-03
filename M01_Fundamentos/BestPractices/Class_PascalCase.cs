// Clase en PascalCase
public class PlayerMovement
{
    // Campo privado en _camelCase (convención común)
    private float _velocidadJugador;

    // Propiedad y método en PascalCase
    public float VelocidadActual => _velocidadJugador;

    public void CalcularVelocidad(float deltaTiempo)
    {
        float aceleracionBase = 2.5f; // variable local en camelCase
        _velocidadJugador += aceleracionBase * deltaTiempo;
    }
}
