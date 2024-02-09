using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStationInterface.Utilities
{
    public class BusSimulationController
    {
        private Task _simulationTask;
        private Action<string> _onStatusUpdate;
        private readonly BusSimulationService _simulationService;
        private CancellationTokenSource _cancellationTokenSource;

        public BusSimulationController(BusSimulationService simulationService, Action<string> onStatusUpdate)
        {
            _simulationService = simulationService;
            _onStatusUpdate = onStatusUpdate;
        }

        public void StartSimulation(int scheduleId)
        {
            _cancellationTokenSource = new CancellationTokenSource();
            var token = _cancellationTokenSource.Token;

            _simulationTask = Task.Run(() =>
            {
                try
                {
                    _onStatusUpdate?.Invoke("Simulation started.");
                    _simulationService.SimulateBusRoute(scheduleId, token);
                    _onStatusUpdate?.Invoke("Simulation completed.");
                }
                catch (OperationCanceledException)
                {
                    _onStatusUpdate?.Invoke("Simulation cancelled.");
                }
                catch (Exception ex)
                {
                    _onStatusUpdate?.Invoke($"Simulation error: {ex.Message}");
                }
            }, token);
        }

        public void StopSimulation()
        {
            if (_cancellationTokenSource != null && !_simulationTask.IsCompleted)
            {
                _cancellationTokenSource.Cancel();
            }
        }
    }

}
