using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MasterDetailApp.Models
{
    public class Product
    {
        #region Enums
        public enum RealEstateType
        {
            NONE,
            COMMERCIAL,
            RESIDENTIAL
        }
        #endregion

        #region Fields

        private string _address;
        private int _bedrooms;
        private int _bathrooms;
        private double _squareFootage;
        private double _lotSize;
        private double _price;
        private int _yearBuilt;
        private double _yearlyTaxes;
        private string _propertyType;
        private RealEstateType _typeOfRealEstate;
        private string _buildingClass;
        private string _saleType;
        private string _parcelID;
        private int _numberOfStories;
        private int _mls;
        private string _imageName;
        private int _zipCode;
        private string _state;
        private string _city;
        private string _imageName2;
        private string _imageName3;
        private string _imageName4;        


        #endregion

        #region Properties

        public string ImageName
        {
            get { return _imageName; }
            set { _imageName = value; }
        }

        public int MLS
        {
            get { return _mls; }
            set { _mls = value; }
        }

        public int NumberOfStories
        {
            get { return _numberOfStories; }
            set { _numberOfStories = value; }
        }

        public string ParcelID
        {
            get { return _parcelID; }
            set { _parcelID = value; }
        }

        public string SaleType
        {
            get { return _saleType; }
            set { _saleType = value; }
        }

        public string BuildingClass
        {
            get { return _buildingClass; }
            set { _buildingClass = value; }
        }

        public RealEstateType TypeOfRealEstate
        {
            get { return _typeOfRealEstate; }
            set { _typeOfRealEstate = value; }
        }

        public string PropertyType
        {
            get { return _propertyType; }
            set { _propertyType = value; }
        }

        public double YearlyTaxes
        {
            get { return _yearlyTaxes; }
            set { _yearlyTaxes = value; }
        }

        public int BuildDate
        {
            get { return _yearBuilt; }
            set { _yearBuilt = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public double LotSize
        {
            get { return _lotSize; }
            set { _lotSize = value; }
        }

        public double SquareFootage
        {
            get { return _squareFootage; }
            set { _squareFootage = value; }
        }

        public int Bathrooms
        {
            get { return _bathrooms; }
            set { _bathrooms = value; }
        }

        public int Bedrooms
        {
            get { return _bedrooms; }
            set { _bedrooms = value; }
        }

        public string State
        {
            get { return _state; }
            set { _state = value; }
        }

        public int ZipCode
        {
            get { return _zipCode; }
            set { _zipCode = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public string ImageName4
        {
            get { return _imageName4; }
            set { _imageName4 = value; }
        }

        public string ImageName3
        {
            get { return _imageName3; }
            set { _imageName3 = value; }
        }

        public string ImageName2
        {
            get { return _imageName2; }
            set { _imageName2 = value; }
        }

        public string ImageFilePath
        {
            get { return @"../Images/" + _imageName; }
        }

        public string ImageFilePath2
        {
            get { return @"../Images/" + _imageName; }
        }

        public string ImageFilePath3
        {
            get { return @"../Images/" + _imageName3; }
        }

        public string ImageFilePath4
        {
            get { return @"../Images/" + _imageName4; }
        }

        #endregion

        #region CONSTRUCTORS

        public Product()
        {

        }

        #endregion

        #region METHODS


        #endregion

        #region EVENTS



        #endregion
    }
}
