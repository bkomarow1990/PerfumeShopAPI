﻿using Ardalis.ApiEndpoints;
using ASP_PerfumeShopAPI.Core.ProjectAggregate;
using ASP_PerfumeShopAPI.Core.ProjectAggregate.Specifications;
using ASP_PerfumeShopAPI.SharedKernel.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ASP_PerfumeShopAPI.Web.Endpoints.ProjectEndpoints
{
    public class GetById : BaseAsyncEndpoint
        .WithRequest<GetProjectByIdRequest>
        .WithResponse<GetProjectByIdResponse>
    {
        private readonly IRepository<Project> _repository;

        public GetById(IRepository<Project> repository)
        {
            _repository = repository;
        }

        [HttpGet(GetProjectByIdRequest.Route)]
        [SwaggerOperation(
            Summary = "Gets a single Project",
            Description = "Gets a single Project by Id",
            OperationId = "Projects.GetById",
            Tags = new[] { "ProjectEndpoints" })
        ]
        public override async Task<ActionResult<GetProjectByIdResponse>> HandleAsync([FromRoute] GetProjectByIdRequest request,
            CancellationToken cancellationToken)
        {
            var spec = new ProjectByIdWithItemsSpec(request.ProjectId);
            var entity = await _repository.GetBySpecAsync(spec); // TODO: pass cancellation token
            if (entity == null) return NotFound();

            var response = new GetProjectByIdResponse
            (
                id: entity.Id,
                name: entity.Name,
                items: entity.Items.Select(item => new ToDoItemRecord(item.Id, item.Title, item.Description, item.IsDone)).ToList()
            );
            return Ok(response);
        }
    }
}