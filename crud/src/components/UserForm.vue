<template>
  <div>
    <v-flex
      xs12
      sm6
      md3
    >
      <v-text-field
        v-model="user.id"
        label="Id"
        readonly
      />
    </v-flex>
    <v-flex
      xs12
      sm6
      md3
    >
      <v-text-field
        v-model="user.username"
        label="Username"
        autofocus
      />
    </v-flex>
    <v-flex
      xs12
      sm6
      md3
    >
      <v-text-field
        v-model="user.firstName"
        label="FirstName"
      />
    </v-flex>
    <v-flex
      xs12
      sm6
      md3
    >
      <v-text-field
        v-model="user.lastName"
        label="LastName"
      />
    </v-flex>
    <v-flex
      xs12
      sm6
      md3
    >
      <v-text-field
        v-model="user.title"
        label="Title"
      />
    </v-flex>
    <v-btn
      color="info"
      @click="save()"
    >
      Save
    </v-btn>
  </div>
</template>
<script>
import UsersService from '@/services/UsersService';

const usersService = new UsersService();

export default {
  name: 'UserForm',
  props: {
    id: String,
    create: Boolean,
  },
  data() {
    return {
      user: {
        id: 0,
        username: null,
        firstName: null,
        lastName: null,
        title: null,
      },
    };
  },
  mounted() {
    if (!this.create) {
      usersService.getById(this.id).then((data) => {
        this.user = data;
      });
    }
  },
  methods: {
    save() {
      if (this.create) {
        usersService.create(this.user).then(() => {
          this.$router.go(-1);
        });
      } else {
        usersService.update(this.id, this.user).then(() => {
          this.$router.go(-1);
        });
      }
    },
    delete() {
      if (!this.create) {
        usersService.delete(this.id);
      }
    },
  },
};
</script>
