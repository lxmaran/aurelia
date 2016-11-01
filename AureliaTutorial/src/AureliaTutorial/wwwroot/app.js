
export class App{
   configureRouter(config, router) {
       this.router = router;

       config.map([
           //set nav:true to be able to get the naviogation link into router.navigation and pasrse and use it in the app.html/nav-bar
            { route: ["", "list"], moduleId: "movies/list", title:"Movies", nav:true, name: "Home"},
            { route: "about", moduleId: "about/about", title:"About", nav:true},
            { route: "details/:id", moduleId: "movies/details", title: "Details", name:"details"}
       ]);
   }
}
