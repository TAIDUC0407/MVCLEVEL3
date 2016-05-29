/// <reference path="/Assets/admin/libs/angular/angular.js" />
(function () {
    angular.module('tedushop.product_categories', ['tedushop.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('product_categories', {
            url: "/product_categories",
            templateUrl: "/app/components/product_categories/productCategoryListView.html",
            controller: "productCategoryListController"
        });
    }
})();

//.state('productcategorie_add', {
//    url: "/productcategorie_add",
//    templateUrl: "/app/components/product_categories/productCategoryAddView.html",
//    controller: "productCategoryAddController"
//}).state('productcategorie_edit', {
//    url: "/productcategorie_edit",
//    templateUrl: "/app/components/product_categories/productCategoryEditView.html",
//    controller: "productCategoryEditController"
//})