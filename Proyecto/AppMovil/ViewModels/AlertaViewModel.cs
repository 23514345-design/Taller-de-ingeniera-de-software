using System.Collections.ObjectModel;

public class AlertaViewModel
{
    public ObservableCollection<Alerta> Alertas { get; set; }

    public AlertaViewModel()
    {
        Alertas = new ObservableCollection<Alerta>()
        {
            new Alerta { Mensaje = "Obstáculo detectado", Distancia = 40, EsCritica = true },
            new Alerta { Mensaje = "Sistema activo", Distancia = 0, EsCritica = false }
        };
    }
}
