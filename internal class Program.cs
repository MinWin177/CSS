internal class Program
{
    private static void Main(string[] args)
    {
        global::System.Boolean v = </ style >
</ head >
< body >
    < header >
        < h1 > Shop; Online </ h1 >
    </ header >
    < main >
        < section = "products" >
            < div = "product" >
                < img src = "product1.jpg" alt = "Sản phẩm 1" >
                < h2 > Sản phẩm 1</h2>
                <p>Giá: 100.000đ </ p >
                < button onclick = "addToCart('Sản phẩm 1', 100000)" > Thêm vào giỏ</button>
            </div>
            <div = "product" >
                < img src = "product2.jpg" alt = "Sản phẩm 2" >
                < h2 > Sản phẩm 2</h2>
                <p>Giá: 150.000đ </ p >
                < button onclick = "addToCart('Sản phẩm 2', 150000)" > Thêm vào giỏ</button>
            </div>
        </section>
        <section = "cart" >
            < h2 > Giỏ hàng </ h2 >
            < ul id = "cart-items" ></ ul >
            < p > Tổng: < span id = "total" > 0 </ span > đ </ p >
        </ section >
    </ main >
    < script >
        let cart = [];
        function addToCart(name, price)
        {
            cart.push({ name, price });
            updateCart();
        }
        function updateCart()
        {
            let cartList = document.getElementById('cart-items');
            let totalPrice = 0;
            cartList.innerHTML = '';
            cart.forEach(item =>
            {
                let li = document.createElement('li');
                li.textContent = `${ item.name}
                - ${ item.price}
                đ`;
                cartList.appendChild(li);
                totalPrice += item.price;
            });
            document.getElementById('total').textContent = totalPrice;
        }
    </ script >
</ body >
</ html >
}
}

classclassclassclass