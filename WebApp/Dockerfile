FROM node

EXPOSE 5000/tcp

WORKDIR /WebApp

ADD ./package.json ./package.json

RUN npm install

RUN npm install -g nodemon

ADD . /WebApp

WORKDIR /WebApp

#CMD [ "bash"]
CMD [ "nodemon", "--legacy-watch", "server.js" ]