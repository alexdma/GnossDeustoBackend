﻿using API_CARGA.ViewModel;
using Swashbuckle.AspNetCore.Filters;

namespace API_CARGA.ModelExamples
{
    ///<summary>
    ///Sirve para mostrar un error al añadir un shape
    ///</summary>
    public class AddShapeConfigErrorResponse : IExamplesProvider<ErrorExample>
    {
        public ErrorExample GetExamples()
        {
            return new ErrorExample
            {
                Error = "Check that shape config with id {identifier} exist"
            };
        }
    }
}
