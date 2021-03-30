package main

import (
	"github.com/gin-gonic/gin"
	"net/http"
	"strconv"
)

func main() {
	r := gin.Default()
	r.GET("/user/:name", func(c *gin.Context) {
		//c.JSON(200,gin.H{
		//	"message":"pong",
		//})
		name := c.Param("name")
		c.String(http.StatusOK, "Hello %s", name)
	})

	r.GET("/user/:name/*action", func(c *gin.Context) {
		name := c.Param("name")
		action := c.Param("action")
		message := name + " is " + action
		c.String(http.StatusOK, message)
	})

	r.POST("/user/:name/*action", func(c *gin.Context) {
		//name := c.Param("name")
		//action := c.Param("action")
		b := c.FullPath() == "/user/:name/*action"
		c.String(http.StatusOK, c.FullPath()+"----"+strconv.FormatBool(b))
	})

	///welcome?firstname=Jane&lastname=Doe
	r.GET("/welcome", func(c *gin.Context) {
		firstname := c.DefaultQuery("firstname", "Guest")
		lastname := c.Query("lastname") // shortcut for c.Request.URL.Query().Get("lastname")
		c.String(http.StatusOK, "Hello %s %s", firstname, lastname)
	})

	r.POST("/form_post", func(c *gin.Context) {
		//Post Body form-data
		message := c.PostForm("message")
		nick := c.DefaultPostForm("nick", "anonymous")
		c.JSON(200, gin.H{
			"status":  "posted",
			"message": message,
			"nick":    nick,
		})
	})

	r.POST("/post", func(c *gin.Context) {
		id := c.Query("id")
		page := c.DefaultQuery("page", "0")
		name := c.PostForm("name")
		message := c.PostForm("message")
		c.String(http.StatusOK, "id: %s; page: %s; name: %s; message: %s", id, page, name, message)
	})

	// Todo: debug
	r.POST("/post_map", func(c *gin.Context) {
		ids := c.QueryMap("ids")
		names := c.PostFormMap("names")
		c.String(http.StatusOK, "ids: %s; names: %s", len(ids), len(names))
	})



	r.Run(":3030") // listen and serve on 0.0.0.0:8080
}
