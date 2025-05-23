# EasyChat

本程序实现了MQTT在局域网中不同客户端互相通讯的功能，主界面使用WPF模仿微信主界面绘制。主要用到的技术栈：MVVM、MQTT、WPF.Ui

> 优点：

1. 无需连接外网，适合局域网使用，例如车间调试工程师；
2. 没有数据库，不会存储聊天记录，安全无监控；
3. 使用AES对称加密算法加密消息体，不怕抓包。
4. 软件体积小，占用磁盘空间10M左右（其中一大半是UI资源）

> 缺点：

1. 仅支持Windows系统。

#### 登录界面
<img src="https://github.com/agd-yy/EasyChat/blob/main/img/login1.png" width="50%" height="50%">
<img src="https://github.com/agd-yy/EasyChat/blob/main/img/login1.png" width="50%" height="50%">

#### 主界面
<img src="https://github.com/agd-yy/EasyChat/blob/main/img/main1.png" width="50%" height="50%">
<img src="https://github.com/agd-yy/EasyChat/blob/main/img/main2.png" width="50%" height="50%">

> 待办项：

- [ ] 程序运行内存优化
- [ ] UI界面优化
- [x] UI:炫酷的登录界面
- [x] UI:炫酷的主界面
- [x] 头像功能
- [x] 顶部图标功能:固定、最小化、最大化、隐藏
- [x] 新消息提醒功能
- [x] 实现聊天功能
- [x] 可以给自己发消息，默认给自己置顶
- [ ] 添加群聊功能
- [ ] 添加搜索功能
- [ ] 添加自定义功能：头像、昵称
- [ ] 任务栏添加鼠标悬浮展示新消息内容功能
- [x] 支持主题切换
- [x] 支持头像切换
- [x] 图片文件发送接收功能
- [x] 支持同时发送多个文件或图片
- [ ] 图片缩略图展示
- [ ] 支持鼠标拖拽文件或者图片发送
- [ ] 文件传输展示进度条
