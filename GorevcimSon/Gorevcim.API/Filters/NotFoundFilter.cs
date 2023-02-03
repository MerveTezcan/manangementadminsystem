using Gorevcim.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Microsoft.AspNetCore.Mvc.Filters;
using Gorevcim.Core;
using Microsoft.AspNetCore.Mvc;
using Gorevcim.Core.Services;
using System.Threading.Tasks;
using Gorevcim.Core.DTOs;


namespace Gorevcim.API.Filters
{
    public class NotFoundFilter<T> :  IAsyncActionFilter where T: BaseEntity
    {
        private readonly IGenericService<T> _service;
        public NotFoundFilter(IGenericService<T> service)
        {
            _service = service;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var idValue = context.ActionArguments.Values.FirstOrDefault();
            if (idValue == null)
            {
                await next.Invoke();
                return;
            }

            var id = (int)idValue;
            var anyEntity = await _service.AnyAsync(x => x.Id == id);

            if (anyEntity)
            {
                await next.Invoke();
                return;
            }


            context.Result = new NotFoundObjectResult(CustomResponseDto<NoContentDto>.Fail(404, $"{typeof(T).Name}({id}) bulunamadı"));


        }

    }
}
