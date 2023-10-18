using System.ComponentModel;

namespace WebAPI.AutoMapper.Enums
{
    public enum MaritalStatusEnum
    {

        [Description("Solteiro")]
        Solteiro,
        [Description("Casado")]
        Casado,
        [Description("Viúvo")]
        Viuvo,
        [Description("Separado")]
        Separado
    }
}
