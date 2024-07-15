namespace TareasMVC.Entidades
{
    public class CashierRecords
    {
        public int Id { get; set; }
        public string EMPLEADO_JOB { get; set; }
        public string JOB { get; set; }
        public string AKEY { get; set; }
        public string MATRIX_PART { get; set; }
        public byte AKEY_ESCANEADO { get; set; }
        public string UBICACION { get; set; }
        public byte REGISTRADO { get; set; }
        public DateTime DATE_JOB { get; set; }
        public DateTime DATE_AKEY { get; set; }
        public string EMPLEADO_AKEY { get; set; }
        public byte JOB_TERMINADO { get; set; }
        public DateTime DATE_JOBEND { get; set; }

    }
}
