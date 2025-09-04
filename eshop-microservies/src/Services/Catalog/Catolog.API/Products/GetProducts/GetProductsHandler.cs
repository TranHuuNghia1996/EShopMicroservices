﻿using Marten.Linq.QueryHandlers;

namespace Catolog.API.Products.GetProducts
{
    public record GetProductsQuery() : IQuery<GetProductsResult>;
    public record GetProductsResult(IEnumerable<Product> Products);
    internal class GetProductsHandler(IDocumentSession session,ILogger<GetProductsHandler> logger) : IQueryHandler<GetProductsQuery, GetProductsResult>
 
    {
        public async Task<GetProductsResult> Handle(GetProductsQuery query, CancellationToken cancellationToken)
        {
            logger.LogInformation("GetProductsQueryHandler.Handler called with {@Query}",query);
            var products = await session.Query<Product>().ToListAsync(cancellationToken);
            return new GetProductsResult(products);
        }
    }
}
