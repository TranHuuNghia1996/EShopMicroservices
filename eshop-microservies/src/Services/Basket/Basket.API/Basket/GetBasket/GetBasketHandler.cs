
namespace Basket.API.Basket.GetBasket
{
    public record GetBasketCommand(string UserName):IQuery<GetBasketResult>;
    public record GetBasketResult(ShoppingCart Cart);
    public class GetBasketHandler(IBasketRepository repository)
        : IQueryHandler<GetBasketCommand, GetBasketResult>
    {
        public async Task<GetBasketResult> Handle(GetBasketCommand query, CancellationToken cancellationToken)
        {
            var baskets =  await repository.GetBasket(query.UserName,cancellationToken);
            return new GetBasketResult(baskets);
        }
    }
}
 