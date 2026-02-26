/* EXPLANATORY COMMENT: This file participates in the NovaExpediente solution and contains implementation details for its corresponding feature. */
module.exports = {
  lintOnSave: false,
  runtimeCompiler: true,
  configureWebpack: {
    //Necessary to run npm link https://webpack.js.org/configuration/resolve/#resolve-symlinks
    resolve: {
      symlinks: false
    }
  },
  transpileDependencies: ["@coreui/utils"],
  //baseUrl: "./",
 // assetsDir: "./"
};
