<template>
  <div>
    <v-btn
      color="info"
      to="/users/create"
    >
      Create User
    </v-btn>

    <UserList />
  </div>
</template>

<script>
// @ is an alias to /src
import UserList from '@/components/UserList.vue';

export default {
  name: 'Users',
  components: {
    UserList,
  },
};
</script>
