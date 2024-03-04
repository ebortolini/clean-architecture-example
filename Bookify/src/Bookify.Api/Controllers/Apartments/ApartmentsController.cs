﻿using Bookify.Application.Apartments.SearchApartments;
using Bookify.Domain.Abstratcions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Bookify.Api.Controllers.Apartments
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApartmentsController : ControllerBase
    {
        private readonly ISender _sender;

        public ApartmentsController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet]
        public async Task<IActionResult> SearchApartments(
            DateOnly startDate,
            DateOnly endDate,
            CancellationToken cancellationToken)
        {
            var query = new SearchApartmentsQuery(startDate, endDate);

            Result<IReadOnlyList<ApartmentResponse>> result = await _sender.Send(query, cancellationToken);

            return Ok(result.Value);
        }

    }
}
