using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF_MasterDetailApp;
using WPF_MasterDetailApp.Models;

namespace WPF_MasterDetailApp.BusinessLayer
{
    public class ProductBL
    {
        #region ENUMS



        #endregion

        #region FIELDS

        ProductWindowView _productWindowView;
        ProductWindowPresenter _productWindowPresenter;

        #endregion

        #region PROPERTIES

        #endregion

        #region CONSTRUCTORS

        public ProductBL()
        {
            //
            // instantiate the view model and initialize the data set
            //

            _productWindowPresenter = new ProductWindowPresenter(GetCompanyData(), GetProductData());

            //
            // instantiate, set the data context, and show the Main Window
            //
            _productWindowView = new ProductWindowView(_productWindowPresenter);
            _productWindowView.DataContext = _productWindowPresenter;
            _productWindowView.Show();
        }

        #endregion

        #region METHODS

        private AvailableProducts GetImageInfo()
        {
            return new AvailableProducts();
        }

        private Company GetCompanyData()
        {
            return new Company()
            {
                Name = "Peej Reality",
                Address = "14363 Rainbow Ave",
                City = "Kaleva"
            };
        }

        private Product GetProductData()
        {
            return new Product()
                {
                    MLS = 1855011,
                    Address = "10860 Bluff Rd.",
                    City = "Traverse City",
                    State = "MI",
                    ZipCode = 49686,
                    TypeOfRealEstate = Product.RealEstateType.RESIDENTIAL,
                    Price = 4400000,
                    Bedrooms = 4,
                    Bathrooms = 6,
                    SquareFootage = 7255,
                    LotSize = 1.14,
                    BuildDate = 2018,
                    YearlyTaxes = 58080.00,
                    ImageName = "10860Bluff1.jpg",
                    ImageName2 = "10860Bluff2.jpg",
                    ImageName3 = "10860Bluff3.jpg",
                    ImageName4 = "10860Bluff4.jpg",
                    NumberOfStories = 2
                };
        }

        #endregion

        #region EVENTS


        #endregion


    }
}
