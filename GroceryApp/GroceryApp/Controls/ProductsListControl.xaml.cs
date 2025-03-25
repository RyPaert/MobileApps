using CommunityToolkit.Mvvm.Input;
using GroceryApp.Shared.Dtos;

namespace Controls;
public class ProductCartItemChangeEventArgs : EventArgs
{
    public ProductCartItemChangeEventArgs(int productId, int count)
    {
        ProductId = productId;
        Count = count;
    }

    public int ProductId { get; set; }
	public int Count { get; set; }
}
public partial class ProductsListControl : ContentView
{
    public static readonly BindableProperty ProductsProperty =
        BindableProperty.Create(nameof(Products), typeof(IEnumerable<ProductDto>), typeof(ProductsListControl), Enumerable.Empty<ProductDto>());
    public ProductsListControl()
	{
		InitializeComponent();
	}
    public event EventHandler<ProductCartItemChangeEventArgs> AddRemoveCartClicked;

    public IEnumerable<ProductDto> Products
	{
		get => (IEnumerable<ProductDto>)GetValue(ProductsProperty);
		set => SetValue(ProductsProperty, value);
	}
    [RelayCommand]
    private void AddToCart(int productId) => 
        AddRemoveCartClicked?.Invoke(this, new ProductCartItemChangeEventArgs(productId, 1));

    [RelayCommand]
    private void RemoveFromCart(int productId) =>
        AddRemoveCartClicked?.Invoke(this, new ProductCartItemChangeEventArgs(productId, -1));
}